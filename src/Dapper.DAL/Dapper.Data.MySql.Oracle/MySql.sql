CREATE TABLE `administrator` (
    `Administrator` varchar(32) NOT NULL,
    `Telphone` varchar(32) NULL,
    `MobileTel` varchar(32) NULL,
    `EMail` varchar(32) NULL,
    `AckLevel` int(11) NULL DEFAULT '0',
    `Reserve1` longtext NULL,
    `Reserve2` longtext NULL,
    `Reserve3` longtext NULL,
    PRIMARY KEY (`Administrator`)
);

CREATE TABLE `alarmproc` (
    `Proc_Code` int(11) NULL DEFAULT '0',
    `Proc_Module` varchar(32) NULL,
    `Proc_name` varchar(48) NULL,
    `Proc_parm` varchar(200) NULL,
    `Comment` varchar(240) NULL
);

CREATE TABLE `alarmrec` (
    `proc_name` varchar(48) NULL,
    `Administrator` varchar(32) NOT NULL,
    `event` varchar(128) NOT NULL,
    `comment` varchar(64) NULL
);

CREATE TABLE `almreport` (
    `id` int(11) NOT NULL AUTO_INCREMENT,
    `sta_n` int(11) NULL DEFAULT '0',
    `group_no` int(11) NULL DEFAULT '0',
    `Administrator` varchar(32) NULL,
    PRIMARY KEY (`id`)
);

CREATE TABLE `autoproc` (
    `ID` int(11) NOT NULL AUTO_INCREMENT,
    `iequip_no` int(11) NULL DEFAULT '0',
    `iycyx_no` int(11) NULL DEFAULT '0',
    `iycyx_type` varchar(16) NULL,
    `delay` int(11) NULL DEFAULT '0',
    `oequip_no` int(11) NULL DEFAULT '0',
    `oset_no` int(11) NULL,
    `value` varchar(255) NULL,
    `ProcDesc` varchar(255) NULL,
    `Enable` int(11) NULL DEFAULT '1',
    PRIMARY KEY (`ID`)
);

CREATE TABLE `cur_data` (
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
    `STA_N` int(11) NULL DEFAULT '0',
    `EQUIP_NO` int(11) NULL DEFAULT '0',
    `YC_NO` int(11) NULL DEFAULT '0',
    `data` longblob NULL
);

CREATE TABLE `drgrdrcd` (
    `guard_no` int(11) NULL DEFAULT '0',
    `door_id` int(11) NULL,
    `card_id` int(11) NULL,
    `Name` varchar(32) NULL,
    `Action` varchar(64) NULL
);

CREATE TABLE `dutysat` (
    `YYMM` varchar(8) NULL,
    `ID` varchar(8) NOT NULL,
    `Name` varchar(32) NULL,
    `D1` varchar(2) NULL,
    `D2` varchar(2) NULL,
    `D3` varchar(2) NULL,
    `D4` varchar(2) NULL,
    `D5` varchar(2) NULL,
    `D6` varchar(2) NULL,
    `D7` varchar(2) NULL,
    `D8` varchar(2) NULL,
    `D9` varchar(2) NULL,
    `D10` varchar(2) NULL,
    `D11` varchar(2) NULL,
    `D12` varchar(2) NULL,
    `D13` varchar(2) NULL,
    `D14` varchar(2) NULL,
    `D15` varchar(2) NULL,
    `D16` varchar(2) NULL,
    `D17` varchar(2) NULL,
    `D18` varchar(2) NULL,
    `D19` varchar(2) NULL,
    `D20` varchar(2) NULL,
    `D21` varchar(2) NULL,
    `D22` varchar(2) NULL,
    `D23` varchar(2) NULL,
    `D24` varchar(2) NULL,
    `D25` varchar(2) NULL,
    `D26` varchar(2) NULL,
    `D27` varchar(2) NULL,
    `D28` varchar(2) NULL,
    `D29` varchar(2) NULL,
    `D30` varchar(2) NULL,
    `D31` varchar(2) NULL,
    `M_OnTm_Count` int(11) NULL DEFAULT '0',
    `M_Late_Count` int(11) NULL DEFAULT '0',
    `M_LeaveEarly_Count` int(11) NULL DEFAULT '0',
    `A_OnTm_Count` int(11) NULL DEFAULT '0',
    `A_Late_Count` int(11) NULL DEFAULT '0',
    `A_LeaveEarly_Count` int(11) NULL DEFAULT '0'
);

CREATE TABLE `dutyset` (
    `M_InTm_Bgn` varchar(8) NULL,
    `M_InTm_End` varchar(8) NULL,
    `M_Late_Bgn` varchar(8) NULL,
    `M_Late_End` varchar(8) NULL,
    `M_Leave_Early_Bgn` varchar(8) NULL,
    `M_Leave_Early_End` varchar(8) NULL,
    `M_Leave_OnTm_Bgn` varchar(8) NULL,
    `M_Leave_OnTm_End` varchar(8) NULL,
    `A_InTm_Bgn` varchar(8) NULL,
    `A_InTm_End` varchar(8) NULL,
    `A_Late_Bgn` varchar(8) NULL,
    `A_Late_End` varchar(8) NULL,
    `A_Leave_Early_Bgn` varchar(8) NULL,
    `A_Leave_Early_End` varchar(8) NULL,
    `A_Leave_OnTm_Bgn` varchar(8) NULL,
    `A_Leave_OnTm_End` varchar(8) NULL
);

CREATE TABLE `employee` (
    `ID` varchar(8) NOT NULL,
    `Name` varchar(32) NULL,
    `CardNo` varchar(16) NULL
);

CREATE TABLE `equip` (
    `equip_no` int(11) NOT NULL AUTO_INCREMENT,
    `sta_n` int(11) NULL DEFAULT '0',
    `equip_nm` varchar(64) NOT NULL,
    `equip_detail` varchar(255) NULL,
    `acc_cyc` int(11) NULL,
    `related_pic` varchar(255) NULL,
    `proc_advice` varchar(254) NULL,
    `out_of_contact` varchar(64) NOT NULL,
    `contacted` varchar(64) NULL,
    `event_wav` varchar(64) NULL,
    `communication_drv` varchar(128) NULL,
    `local_addr` varchar(128) NULL,
    `equip_addr` varchar(255) NULL,
    `communication_param` longtext NULL,
    `communication_time_param` varchar(32) NULL,
    `raw_equip_no` int(11) NULL DEFAULT '0',
    `tabname` varchar(15) NULL,
    `alarm_scheme` int(11) NULL DEFAULT '0',
    `attrib` int(11) NULL DEFAULT '0',
    `sta_IP` varchar(255) NULL,
    `AlarmRiseCycle` int(11) NULL DEFAULT '0',
    `Reserve1` longtext NULL,
    `Reserve2` longtext NULL,
    `Reserve3` longtext NULL,
    `related_video` varchar(255) NULL,
    `ZiChanID` varchar(255) NULL,
    `PlanNo` varchar(255) NULL,
    `SafeTime` longtext NULL,
    PRIMARY KEY (`equip_no`)
);

CREATE TABLE `equipgroup` (
    `group_no` int(11) NOT NULL AUTO_INCREMENT,
    `sta_n` int(11) NULL DEFAULT '0',
    `group_name` varchar(50) NOT NULL,
    `equipcomb` longtext NULL,
    PRIMARY KEY (`group_no`)
);

CREATE TABLE `equipoperation` (
    `sta_nm` varchar(10) NOT NULL,
    `equip_id` varchar(16) NOT NULL,
    `OPERATION_ID` int(11) NULL DEFAULT '0',
    `OPERATION_TITLE` varchar(255) NOT NULL
);

CREATE TABLE `exproc_all` (
    `Proc_Code` int(11) NULL DEFAULT '0',
    `Proc_Module` varchar(32) NULL,
    `Proc_name` varchar(48) NULL,
    `Proc_parm` varchar(200) NULL,
    `Comment` varchar(240) NULL
);

CREATE TABLE `gisconfig` (
    `ID` int(11) NOT NULL AUTO_INCREMENT,
    `ControlType` varchar(50) NULL,
    `Location` varchar(50) NULL,
    `Image` varchar(50) NULL,
    `CheckImage` varchar(50) NULL,
    `AlarmImage` varchar(50) NULL,
    `ClickCmd` varchar(50) NULL,
    `AlarmExpression` varchar(50) NULL,
    `Zoom` int(11) NULL DEFAULT '0',
    `MaxZoomNum` int(11) NULL DEFAULT '0',
    `MinZoomNum` int(11) NULL DEFAULT '0',
    `Tooltip` varchar(50) NULL,
    `ImageWith` int(11) NULL DEFAULT '0',
    `ImageHight` int(11) NULL DEFAULT '0',
    `OffsetPoint` varchar(255) NULL,
    PRIMARY KEY (`ID`)
);

CREATE TABLE `gisrouteconfig` (
    `ID` int(11) NOT NULL AUTO_INCREMENT,
    `RouteName` varchar(255) NULL,
    `StartPoint` varchar(255) NULL,
    `EndPoint` varchar(255) NULL,
    PRIMARY KEY (`ID`)
);

CREATE TABLE `gw_alarminfo` (
    `Id` int(11) NOT NULL AUTO_INCREMENT,
    `Name` varchar(255) NULL,
    `path` longtext NULL,
    `equip_no` int(11) NULL DEFAULT '0',
    `ycyx_type` varchar(255) NULL,
    `ycyx_no` int(11) NULL DEFAULT '0',
    `action` varchar(255) NULL,
    `related_video` varchar(255) NULL,
    `zichan_no` varchar(255) NULL,
    `plan_no` varchar(255) NULL,
    `related_pic` varchar(255) NULL,
    PRIMARY KEY (`Id`)
);

CREATE TABLE `gw_home_menu` (
    `ID` int(11) NULL,
    `groupID` int(11) NULL,
    `modulName` text NULL,
    `menuName` text NULL,
    `iconName` text NULL,
    `Reserve1` text NULL,
    `Reserve2` text NULL,
    `Reserve3` text NULL
);

CREATE TABLE `gw_home_menu_status` (
    `ID` int(11) NOT NULL,
    `userName` varchar(50) NOT NULL,
    `modulName` varchar(50) NULL,
    `status` varchar(50) NULL,
    `Reserve1` text NULL,
    `Reserve2` text NULL,
    `Reserve3` text NULL
);

CREATE TABLE `gw_language` (
    `id` int(11) NOT NULL,
    `userName` varchar(50) NULL,
    `languageType` int(11) NULL,
    `voiceType` int(11) NULL,
    `Reserve1` varchar(255) NULL,
    `Reserve2` varchar(255) NULL,
    `Reserve3` varchar(255) NULL
);

CREATE TABLE `gw_mj_card` (
    `card_id` int(11) NOT NULL,
    `member_id` int(11) NULL,
    `card_no` varchar(255) NULL,
    `pwd` varchar(255) NULL,
    `valided` bit(1) NOT NULL,
    `Reserve1` varchar(255) NULL,
    `Reserve2` varchar(255) NULL,
    `Reserve3` varchar(255) NULL,
    `Reserve4` varchar(255) NULL
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
    `dept_nm` varchar(255) NULL
);

CREATE TABLE `gw_mj_doorinfo` (
    `equip_no` int(11) NOT NULL,
    `door_id` int(11) NOT NULL,
    `path` longtext NULL,
    `door_name` varchar(255) NULL,
    `related_video` varchar(255) NULL,
    `ZiChanID` varchar(255) NULL,
    `PlanNo` varchar(255) NULL,
    `Statue` varchar(255) NULL,
    `AttendanceLocusFlag` bit(1) NOT NULL,
    `Reserve1` varchar(255) NULL,
    `Reserve2` varchar(255) NULL,
    `Reserve3` varchar(255) NULL,
    `Reserve4` varchar(255) NULL
);

CREATE TABLE `gw_mj_doorparam` (
    `equip_no` int(11) NULL,
    `door_id` int(11) NULL,
    `name` varchar(255) NULL,
    `paramtype` varchar(255) NULL,
    `disName` varchar(255) NULL,
    `value` varchar(255) NULL,
    `isUse` bit(1) NOT NULL,
    `remark` varchar(255) NULL
);

CREATE TABLE `gw_mj_drgrdrcd` (
    `guard_no` smallint(6) NULL,
    `door_id` tinyint(4) NULL,
    `card_id` smallint(6) NULL,
    `Name` varchar(32) NULL,
    `Action` varchar(64) NULL
);

CREATE TABLE `gw_mj_holiday` (
    `holiday_id` int(11) NULL,
    `holiday_name` varchar(255) NULL
);

CREATE TABLE `gw_mj_holidayatdoor` (
    `holiday_id` int(11) NULL,
    `equip_no` int(11) NULL,
    `door_id` int(11) NULL
);

CREATE TABLE `gw_mj_member` (
    `member_id` int(11) NOT NULL AUTO_INCREMENT,
    `dept_id` int(11) NULL,
    `member_name` varchar(255) NULL,
    `traffic_group_id` int(11) NULL,
    `tel` varchar(255) NULL,
    `addr` varchar(255) NULL,
    `member_statue` varchar(255) NULL,
    `head_flag` bit(1) NOT NULL DEFAULT b'0',
    `Reserve1` varchar(255) NULL,
    `Reserve2` varchar(255) NULL,
    `Reserve3` varchar(255) NULL,
    `Reserve4` varchar(255) NULL,
    PRIMARY KEY (`member_id`)
);

CREATE TABLE `gw_mj_multicardgroup` (
    `multi_cards_group_id` int(11) NOT NULL,
    `multi_cards_group_nm` varchar(255) NULL
);

CREATE TABLE `gw_mj_pre_timezone_kingkang` (
    `equip_no` int(11) NULL,
    `door_id` int(11) NULL
);

CREATE TABLE `gw_mj_realtimeinout` (
    `guard_no` int(11) NULL,
    `door_id` int(11) NULL,
    `card_id` int(11) NULL,
    `Name` varchar(255) NULL,
    `Action` varchar(255) NULL
);

CREATE TABLE `gw_mj_timegroup` (
    `time_group_id` int(11) NOT NULL,
    `equip_no` int(11) NULL,
    `time_group_name` varchar(255) NULL,
    `wk_permission` int(11) NULL,
    `Reserve1` varchar(255) NULL,
    `Reserve2` varchar(255) NULL,
    `Reserve3` varchar(255) NULL,
    `Reserve4` varchar(255) NULL
);

CREATE TABLE `gw_mj_timezone_kingkang` (
    `equip_no` int(11) NULL,
    `door_id` int(11) NULL,
    `time_zone_id` int(11) NOT NULL,
    `time_zone_name` varchar(255) NULL,
    `Reserve1` varchar(255) NULL,
    `Reserve2` varchar(255) NULL,
    `Reserve3` varchar(255) NULL,
    `Reserve4` varchar(255) NULL
);

CREATE TABLE `gw_mj_traffic_group` (
    `Group_Id` int(11) NULL,
    `Group_Name` varchar(255) NULL
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
    `CardNo` varchar(255) NULL,
    `Name` varchar(255) NULL,
    `Type` int(11) NULL,
    `Orders` int(11) NULL,
    `GroupId` int(11) NULL,
    PRIMARY KEY (`CardId`)
);

CREATE TABLE `gw_patrol_cardtype` (
    `TypeId` int(11) NOT NULL AUTO_INCREMENT,
    `TypeName` varchar(255) NULL,
    PRIMARY KEY (`TypeId`)
);

CREATE TABLE `gw_patrol_comport` (
    `MeterType` int(11) NOT NULL AUTO_INCREMENT,
    `CommunicationParam` varchar(255) NULL,
    `Port` varchar(255) NULL,
    PRIMARY KEY (`MeterType`)
);

CREATE TABLE `gw_patrol_exception` (
    `ExpId` varchar(255) NOT NULL,
    `ExpName` varchar(255) NULL,
    PRIMARY KEY (`ExpId`)
);

CREATE TABLE `gw_patrol_meter` (
    `MeterId` int(11) NOT NULL AUTO_INCREMENT,
    `MeterNo` varchar(255) NULL,
    `RouteId` int(11) NULL,
    PRIMARY KEY (`MeterId`)
);

CREATE TABLE `gw_patrol_patrolgroup` (
    `GroupId` int(11) NOT NULL AUTO_INCREMENT,
    `GroupName` varchar(255) NULL,
    `ParentId` int(11) NULL DEFAULT '0',
    PRIMARY KEY (`GroupId`)
);

CREATE TABLE `gw_patrol_plandetails` (
    `PlanTableId` int(11) NULL DEFAULT '0',
    `RouteId` int(11) NULL DEFAULT '0',
    `LocusId` varchar(255) NULL,
    `InspectorId` int(11) NULL DEFAULT '0',
    `State` int(11) NULL DEFAULT '3',
    `ExceptionId` varchar(255) NULL
);

CREATE TABLE `gw_patrol_plantable` (
    `PlanTableId` int(11) NULL,
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
    `Orders` int(11) NULL
);

CREATE TABLE `gw_patrol_record_origin` (
    `Id` int(11) NOT NULL AUTO_INCREMENT,
    `Locus` varchar(255) NULL,
    `PatrolMan` varchar(255) NULL,
    `MeterId` varchar(255) NULL,
    `ExceptionId` varchar(255) NULL DEFAULT '0',
    PRIMARY KEY (`Id`)
);

CREATE TABLE `gw_patrol_result` (
    `RouteName` varchar(255) NULL,
    `LocusCardNo` varchar(255) NULL,
    `LocusName` varchar(255) NULL,
    `InspectorName` varchar(255) NULL,
    `StateName` varchar(255) NULL,
    `ExceptionName` varchar(255) NULL
);

CREATE TABLE `gw_patrol_route` (
    `RouteId` int(11) NOT NULL AUTO_INCREMENT,
    `RouteName` varchar(255) NULL,
    `ParentId` int(11) NULL DEFAULT '0',
    PRIMARY KEY (`RouteId`)
);

CREATE TABLE `gw_patrol_routesetting` (
    `SetId` int(11) NOT NULL AUTO_INCREMENT,
    `RouteId` int(11) NULL,
    `LocusId` int(11) NULL DEFAULT '0',
    `StayTime` int(11) NULL,
    `Orders` int(11) NULL,
    PRIMARY KEY (`SetId`)
);

CREATE TABLE `gw_patrol_status` (
    `ID` int(11) NOT NULL AUTO_INCREMENT,
    `Status` varchar(50) NULL,
    PRIMARY KEY (`ID`)
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
    PRIMARY KEY (`ID`)
);

CREATE TABLE `gw_qr_check` (
    `qrtype` int(11) NULL DEFAULT '0',
    `qrcreatname` varchar(255) NULL,
    `vistorname` varchar(255) NULL,
    `actionid` varchar(255) NOT NULL,
    `result` int(11) NULL DEFAULT '0',
    `Reserve1` longtext NULL,
    `Reserve2` longtext NULL,
    `Reserve3` longtext NULL
);

CREATE TABLE `gw_qr_record` (
    `qrtype` int(11) NULL DEFAULT '0',
    `qrcreatname` varchar(255) NULL,
    `vistorname` varchar(255) NULL,
    `actionid` varchar(255) NOT NULL,
    `result` int(11) NULL DEFAULT '0',
    `Reserve1` longtext NULL,
    `Reserve2` longtext NULL,
    `Reserve3` longtext NULL
);

CREATE TABLE `gw_sp_area` (
    `AreaID` int(11) NOT NULL AUTO_INCREMENT,
    `AreaName` longtext NULL,
    `AreaDvr_Channel` longtext NULL,
    PRIMARY KEY (`AreaID`)
);

CREATE TABLE `gw_sp_channel` (
    `ID` int(11) NOT NULL,
    `DvrID` int(11) NULL,
    `ChannelID` int(11) NULL,
    `ChannelName` longtext NULL,
    `IsCound` bit(1) NOT NULL DEFAULT b'0',
    `CompactName` varchar(255) NULL,
    `equip_addr` varchar(255) NULL,
    `communication_param` varchar(255) NULL
);

CREATE TABLE `gw_sp_dvrinfo` (
    `DvrID` int(11) NOT NULL AUTO_INCREMENT,
    `DvrName` varchar(255) NULL,
    `IP` longtext NULL,
    `UserName` longtext NULL,
    `PassWord` longtext NULL,
    `Port` int(11) NULL,
    `ChannelNum` int(11) NULL,
    `Describe` varchar(255) NULL,
    `DvrType` int(11) NULL DEFAULT '0',
    `CloudMultiple` int(11) NULL DEFAULT '0',
    `CloudSpeed` int(11) NULL DEFAULT '0',
    PRIMARY KEY (`DvrID`)
);

CREATE TABLE `gw_sp_dvrtype` (
    `DvrTypeID` int(11) NOT NULL AUTO_INCREMENT,
    `DvrTypeName` varchar(50) NULL,
    `ClassName` varchar(50) NULL,
    PRIMARY KEY (`DvrTypeID`)
);

CREATE TABLE `gw_sp_group` (
    `ID` int(11) NOT NULL,
    `GroupName` varchar(255) NULL,
    `GroupList` varchar(255) NULL
);

CREATE TABLE `gw_sp_method` (
    `MethodID` int(11) NOT NULL AUTO_INCREMENT,
    `ModulID` int(11) NULL DEFAULT '0',
    `MethodName` varchar(50) NULL,
    `ClassName` varchar(50) NULL,
    PRIMARY KEY (`MethodID`)
);

CREATE TABLE `gw_sp_modul` (
    `ModulID` int(11) NOT NULL AUTO_INCREMENT,
    `ModulName` varchar(50) NULL,
    `DvrTypeID` int(11) NULL DEFAULT '0',
    `ClassName` varchar(50) NULL,
    PRIMARY KEY (`ModulID`)
);

CREATE TABLE `gw_unity_markview` (
    `SceneID` int(11) NULL,
    `ResID` int(11) NULL,
    `VPosition` varchar(255) NULL,
    `Rotation` varchar(255) NULL
);

CREATE TABLE `gw_unity_model` (
    `ID` double NULL,
    `Name` varchar(255) NULL,
    `ResID` double NULL,
    `ParentID` double NULL,
    `SceneID` double NULL,
    `BestViewPos` varchar(255) NULL,
    `ShowMark` double NULL,
    `BestViewRot` varchar(255) NULL,
    `Rotation` varchar(255) NULL,
    `VPosition` varchar(255) NULL,
    `Scale` varchar(255) NULL,
    `ValueCMD` varchar(255) NULL,
    `WarType` double NULL,
    `ClickCMD` varchar(255) NULL,
    `WarCMD` varchar(255) NULL,
    `ToolTip` varchar(255) NULL
);

CREATE TABLE `gw_unity_parade` (
    `ID` int(11) NOT NULL,
    `SceneID` int(11) NULL DEFAULT '0',
    `VIndex` int(11) NULL DEFAULT '0',
    `ParadeSpeed` double NULL DEFAULT '0',
    `VPosition` varchar(255) NULL,
    `Rotation` varchar(255) NULL
);

CREATE TABLE `gw_unity_resource` (
    `Height` double NULL,
    `ID` double NULL,
    `Name` varchar(255) NULL,
    `Width` double NULL,
    `Type` double NULL,
    `TexName` varchar(255) NULL,
    `DevName` varchar(255) NULL,
    `BestViewPos` varchar(255) NULL,
    `DevIconColor` varchar(255) NULL,
    `DevIconName` varchar(255) NULL,
    `BestViewRot` varchar(255) NULL
);

CREATE TABLE `gw_unity_scene` (
    `ID` int(11) NOT NULL,
    `Name` varchar(255) NULL,
    `ShowName` varchar(255) NULL,
    `MoveSpeed` double NULL DEFAULT '0',
    `XRotSpeed` double NULL DEFAULT '0',
    `YRotSpeed` double NULL DEFAULT '0',
    `PYMoveSpeed` double NULL DEFAULT '0',
    `PYScaleSpeed` double NULL DEFAULT '0',
    `ParadeSpeed` double NULL DEFAULT '0',
    `ParadeID` int(11) NULL DEFAULT '0',
    `InitPos` varchar(255) NULL,
    `InitRot` varchar(255) NULL,
    `WalkInitPos` varchar(255) NULL,
    `WalkInitRot` varchar(255) NULL,
    `OverLookPos` varchar(255) NULL,
    `OverLookRot` varchar(255) NULL,
    `OverLookSize` double NULL DEFAULT '0',
    `SkyBox` varchar(255) NULL,
    `MinMapSize` varchar(255) NULL,
    `Version` varchar(255) NULL,
    `BundleName` varchar(255) NULL
);

CREATE TABLE `gw_video_cyclechannel` (
    `ID` int(11) NOT NULL AUTO_INCREMENT,
    `Name` varchar(255) NULL,
    `Channels` longtext NULL,
    `Interval` int(11) NULL DEFAULT '0',
    `Sort` int(11) NULL DEFAULT '0',
    PRIMARY KEY (`ID`)
);

CREATE TABLE `gw_video_preset` (
    `ID` int(11) NOT NULL,
    `ChannelId` int(11) NULL DEFAULT '0',
    `EquipId` int(11) NULL DEFAULT '0',
    `Name` varchar(255) NULL
);

CREATE TABLE `gw_videoinfo` (
    `sta_n` int(11) NULL DEFAULT '0',
    `EquipNum` int(11) NULL DEFAULT '0',
    `ID` int(11) NOT NULL,
    `ChannelName` varchar(255) NULL,
    `ChannelType` int(11) NULL DEFAULT '0',
    `ChannelNum` varchar(255) NULL,
    `ControlEquip` int(11) NULL DEFAULT '0',
    `Path` longtext NULL,
    `Reserve1` longtext NULL,
    `Reserve2` longtext NULL,
    `Reserve3` longtext NULL,
    `Action` varchar(255) NULL,
    `StreamType` varchar(255) NULL,
    `RTSP` varchar(255) NULL
);

CREATE TABLE `gwaddinmodule` (
    `ID` int(11) NOT NULL AUTO_INCREMENT,
    `Name` varchar(255) NULL,
    `ClassName` varchar(255) NULL,
    `HelpPath` varchar(255) NULL,
    `MultiScreens` varchar(255) NULL,
    `WebPage` char(1) NULL,
    PRIMARY KEY (`ID`)
);

CREATE TABLE `gwassetinfo` (
    `asset_id` varchar(64) NOT NULL,
    `equip_name` varchar(64) NULL,
    `equip_detail` varchar(255) NULL,
    `equip_image` varchar(255) NULL,
    `equip_location` varchar(255) NULL,
    `equip_type` varchar(64) NULL,
    PRIMARY KEY (`asset_id`)
);

CREATE TABLE `gwbuttonproperty` (
    `gwkey` varchar(255) NOT NULL,
    `gwcommand` longtext NULL,
    `gwdatasouce` varchar(255) NULL,
    `gwtype` varchar(255) NULL,
    `gwtooltip` varchar(255) NULL,
    `gwremark` longtext NULL,
    PRIMARY KEY (`gwkey`)
);

CREATE TABLE `gwdatarecorditems` (
    `equip_no` int(11) NULL,
    `data_type` varchar(1) NULL,
    `ycyx_no` int(11) NULL,
    `data_name` varchar(255) NULL,
    `userName` varchar(50) NULL
);

CREATE TABLE `gwdatarecordresult` (
    `equip_no` int(11) NULL,
    `data_type` varchar(1) NOT NULL,
    `ycyx_no` int(11) NULL,
    `data_name` varchar(255) NULL,
    `data_value` varchar(255) NULL
);

CREATE TABLE `gwdelayaction` (
    `ID` int(11) NOT NULL AUTO_INCREMENT,
    `GW_Sta_n` int(11) NULL DEFAULT '0',
    `GW_Equip_no` int(11) NULL DEFAULT '0',
    `GW_Set_no` int(11) NULL DEFAULT '0',
    `GW_Value` varchar(255) NULL,
    `GW_UserNm` varchar(255) NULL,
    `GW_DelayNum` int(11) NULL,
    `GW_State` int(11) NULL,
    `GW_Source` int(11) NULL,
    `Reserve1` longtext NULL,
    `Reserve2` longtext NULL,
    `Reserve3` longtext NULL,
    PRIMARY KEY (`ID`)
);

CREATE TABLE `gwelevatormaintain` (
    `ID` varchar(255) NULL,
    `MaintainCode` varchar(255) NULL,
    `MaintainName` varchar(255) NULL,
    `MaintainPosition` varchar(255) NULL,
    `Address` varchar(255) NULL,
    `Certificate` varchar(255) NULL,
    `CertificateLevel` varchar(255) NULL,
    `EligibilityScope` varchar(255) NULL,
    `VerificationTime` varchar(255) NULL
);

CREATE TABLE `gwelevatormarker` (
    `ID` int(11) NOT NULL AUTO_INCREMENT,
    `ElevatorNum` varchar(50) NOT NULL,
    `ElevatorPosition` varchar(50) NULL,
    `ElevatorPlace` longtext NULL,
    `ElevatorInfo` longtext NULL,
    `ElevatorState` int(11) NULL,
    PRIMARY KEY (`ID`, `ElevatorNum`)
);

CREATE TABLE `gwequippages` (
    `ID` int(11) NOT NULL AUTO_INCREMENT,
    `Name` varchar(255) NULL,
    `Pages` longtext NULL,
    `HelpPath` varchar(255) NULL,
    `MultiScreens` varchar(255) NULL,
    `WebPage` char(1) NULL,
    PRIMARY KEY (`ID`)
);

CREATE TABLE `gwequiptreegroup` (
    `ID` int(11) NOT NULL AUTO_INCREMENT,
    `Name` varchar(50) NULL,
    `ParentID` int(11) NULL DEFAULT '0',
    PRIMARY KEY (`ID`)
);

CREATE TABLE `gwequiptreeitem` (
    `EquipID` int(11) NOT NULL,
    `GroupID` int(11) NOT NULL,
    PRIMARY KEY (`EquipID`, `GroupID`)
);

CREATE TABLE `gwexproc` (
    `Proc_Code` int(11) NOT NULL AUTO_INCREMENT,
    `Proc_Module` varchar(255) NULL,
    `Proc_name` varchar(255) NULL,
    `Proc_parm` varchar(255) NULL,
    PRIMARY KEY (`Proc_Code`)
);

CREATE TABLE `gwexproccmd` (
    `proc_code` int(11) NOT NULL,
    `cmd_nm` varchar(255) NOT NULL,
    `main_instruction` varchar(255) NULL,
    `minor_instruction` varchar(255) NULL,
    `value` varchar(255) NULL,
    `record` bit(1) NOT NULL DEFAULT b'1',
    PRIMARY KEY (`proc_code`, `cmd_nm`)
);

CREATE TABLE `gwmaintainer` (
    `ID` int(11) NOT NULL,
    `MaintainerName` longtext NULL,
    `MaintainerPosition` longtext NULL,
    `MaintainerInfo` longtext NULL,
    `Phone` longtext NULL,
    `Company` longtext NULL
);

CREATE TABLE `gwmapmarker` (
    `MarkerId` int(11) NOT NULL AUTO_INCREMENT,
    `MarkerName` longtext NULL,
    `MarkerType` double NOT NULL,
    `Position` longtext NULL,
    `MinZoom` int(11) NULL DEFAULT '0',
    `MaxZoom` int(11) NULL DEFAULT '0',
    `ClassFullName` longtext NULL,
    `Data` longtext NULL,
    `AssemblyName` longtext NULL,
    `Reserve2` longtext NULL,
    `Reserve3` longtext NULL,
    `Path` longtext NULL,
    `DefaultZoom` double NOT NULL,
    `Offset` varchar(255) NULL,
    `GroupID` varchar(255) NOT NULL,
    `xmlns` longtext NULL,
    `zIndex` int(11) NULL DEFAULT '0',
    PRIMARY KEY (`MarkerId`)
);

CREATE TABLE `gwnavigationproperty` (
    `ID` int(11) NOT NULL AUTO_INCREMENT,
    `navigate_type` varchar(255) NOT NULL,
    `normal_image` varchar(255) NOT NULL,
    `alarm_image` longtext NOT NULL,
    `guanlian_comb` longtext NULL,
    `page_comb` longtext NULL,
    `enable` int(11) NULL,
    PRIMARY KEY (`ID`)
);

CREATE TABLE `gwplan` (
    `PlanNo` varchar(255) NOT NULL,
    `Content` longtext NULL,
    `LastEditor` varchar(255) NULL,
    `Reserve1` longtext NULL,
    `Reserve2` longtext NULL,
    `Reserve3` longtext NULL,
    `IsModel` int(11) NULL,
    PRIMARY KEY (`PlanNo`)
);

CREATE TABLE `gwplanrecord` (
    `PlanNo` varchar(255) NULL,
    `Content` longtext NULL,
    `Editor` varchar(255) NULL,
    `State` varchar(255) NULL
);

CREATE TABLE `gwproccycletable` (
    `TableID` int(11) NOT NULL,
    `DoOrder` int(11) NOT NULL,
    `Type` varchar(255) NULL,
    `equip_no` int(11) NULL,
    `set_no` int(11) NULL DEFAULT '0',
    `value` varchar(255) NULL,
    `proc_code` int(11) NULL DEFAULT '0',
    `cmd_nm` varchar(255) NULL,
    `SleepTime` int(11) NULL,
    `SleepUnit` varchar(255) NULL,
    `Reserve1` longtext NULL,
    `Reserve2` longtext NULL,
    `Reserve3` longtext NULL,
    PRIMARY KEY (`TableID`, `DoOrder`)
);

CREATE TABLE `gwproccycletlist` (
    `TableID` int(11) NOT NULL AUTO_INCREMENT,
    `TableName` varchar(255) NOT NULL DEFAULT 'new task',
    `ZhenDianDo` int(11) NULL,
    `ZhidingDo` int(11) NULL,
    `CycleMustFinish` int(11) NULL,
    `MaxCycleNum` int(11) NULL DEFAULT '0',
    `Reserve1` longtext NULL,
    `Reserve2` longtext NULL,
    `Reserve3` longtext NULL,
    `Reference` longtext NULL,
    PRIMARY KEY (`TableID`)
);

CREATE TABLE `gwprocspectable` (
    `ID` int(11) NOT NULL AUTO_INCREMENT,
    `DateName` varchar(255) NULL,
    `TableID` longtext NULL,
    PRIMARY KEY (`ID`)
);

CREATE TABLE `gwproctimeeqptable` (
    `ID` int(11) NOT NULL AUTO_INCREMENT,
    `TableID` int(11) NULL DEFAULT '0',
    `equip_no` int(11) NULL,
    `set_no` int(11) NULL DEFAULT '0',
    `value` varchar(64) NULL,
    PRIMARY KEY (`ID`)
);

CREATE TABLE `gwproctimesystable` (
    `ID` int(11) NOT NULL AUTO_INCREMENT,
    `TableID` int(11) NULL DEFAULT '0',
    `proc_code` int(11) NULL DEFAULT '0',
    `cmd_nm` varchar(255) NULL,
    PRIMARY KEY (`ID`)
);

CREATE TABLE `gwproctimetlist` (
    `TableID` int(11) NOT NULL AUTO_INCREMENT,
    `TableName` varchar(255) NOT NULL DEFAULT 'new schedule',
    `Comment` varchar(255) NULL,
    `Reference` longtext NULL,
    PRIMARY KEY (`TableID`)
);

CREATE TABLE `gwprocweektable` (
    `Mon` longtext NULL,
    `Tues` longtext NULL,
    `Wed` longtext NULL,
    `Thurs` longtext NULL,
    `Fri` longtext NULL,
    `Sat` longtext NULL,
    `Sun` longtext NULL
);

CREATE TABLE `gwreportinfo` (
    `ID` int(11) NOT NULL AUTO_INCREMENT,
    `ReportName` varchar(255) NULL,
    `Describe` varchar(255) NULL,
    `FileName` varchar(255) NULL,
    `DllName` varchar(255) NULL,
    PRIMARY KEY (`ID`)
);

CREATE TABLE `gwrole` (
    `Name` varchar(128) NOT NULL,
    `ControlEquips` longtext NULL,
    `ControlEquips_Unit` longtext NULL,
    `BrowseEquips` longtext NULL,
    `BrowsePages` longtext NULL,
    `remark` longtext NULL,
    `SpecialBrowseEquip` longtext NULL,
    `SystemModule` longtext NULL,
    PRIMARY KEY (`Name`)
);

CREATE TABLE `gwsnapshotconfig` (
    `ID` int(11) NOT NULL AUTO_INCREMENT,
    `SnapshotName` varchar(128) NULL,
    `SnapshotLevelMin` int(11) NULL,
    `SnapshotLevelMax` int(11) NULL,
    `MaxCount` int(11) NULL,
    `IsShow` int(11) NULL,
    `IconRes` varchar(255) NULL,
    `Reserve1` longtext NULL,
    `Reserve2` longtext NULL,
    `Reserve3` longtext NULL,
    PRIMARY KEY (`ID`)
);

CREATE TABLE `gwuser` (
    `ID` int(11) NOT NULL AUTO_INCREMENT,
    `Name` varchar(128) NULL,
    `Password` longtext NULL,
    `Roles` longtext NULL,
    `HomePages` longtext NULL,
    `AutoInspectionPages` longtext NULL,
    `Remark` longtext NULL,
    `ControlLevel` varchar(255) NULL,
    `Reserve1` varchar(255) NULL,
    `Reserve2` varchar(255) NULL,
    `Reserve3` varchar(255) NULL,
    `oppoUser` varchar(255) NULL,
    PRIMARY KEY (`ID`)
);

CREATE TABLE `gwwebmapmarker` (
    `MarkerId` int(11) NOT NULL,
    `MarkerName` longtext NULL,
    `MarkerType` decimal(18,0) NULL,
    `Size` varchar(50) NULL,
    `Position` text NULL,
    `Data` longtext NULL,
    `OffSet` char(10) NULL,
    `Template` varchar(50) NULL,
    `BindCmd` varchar(50) NULL,
    `Destination` varchar(50) NULL,
    `EnableRotation` int(11) NULL,
    `ProjectName` varchar(50) NULL
);

CREATE TABLE `gwzichanrecord` (
    `ID` int(11) NOT NULL AUTO_INCREMENT,
    `ZiChanID` varchar(255) NOT NULL,
    `WeiHuName` varchar(255) NULL,
    `WeiHuRecord` longtext NULL,
    `ItemAddMan` varchar(255) NULL,
    `Pictures` longtext NULL,
    `Reserve1` longtext NULL,
    `Reserve2` longtext NULL,
    `Reserve3` longtext NULL,
    PRIMARY KEY (`ID`)
);

CREATE TABLE `gwzichantable` (
    `ZiChanID` varchar(255) NOT NULL,
    `ZiChanName` varchar(255) NOT NULL,
    `ZiChanType` varchar(255) NULL,
    `ZiChanImage` varchar(255) NULL,
    `ChangJia` varchar(255) NULL,
    `LianxiRen` varchar(255) NULL,
    `LianxiTel` varchar(255) NULL,
    `LianxiMail` varchar(255) NULL,
    `ZiChanSite` varchar(255) NULL,
    `WeiHuCycle` int(11) NULL,
    `LastEditMan` varchar(255) NULL,
    `related_pic` varchar(255) NULL,
    `Reserve1` longtext NULL,
    `Reserve2` longtext NULL,
    `Reserve3` longtext NULL,
    PRIMARY KEY (`ZiChanID`)
);

CREATE TABLE `gwzichantableexcolumn` (
    `ColumnNo` varchar(255) NOT NULL,
    `ColumnName` varchar(255) NULL,
    PRIMARY KEY (`ColumnNo`)
);

CREATE TABLE `hsncardno` (
    `sta_n` int(11) NOT NULL,
    `equip_no` int(11) NOT NULL,
    `Card_No` varchar(6) NOT NULL,
    `Card_Code` varchar(10) NOT NULL,
    `Permission` varchar(1) NOT NULL DEFAULT '1'
);

CREATE TABLE `iot_device` (
    `deviceId` varchar(50) NOT NULL,
    `equipNo` int(11) NULL,
    `nodeId` varchar(50) NULL,
    `nodeType` varchar(50) NULL,
    `gatewayId` varchar(50) NULL,
    `description` varchar(255) NULL,
    `manufactureId` varchar(50) NULL,
    `manufactureName` varchar(255) NULL,
    `mac` varchar(50) NULL,
    `location` varchar(255) NULL,
    `deviceType` varchar(50) NULL,
    `model` varchar(50) NULL,
    `swVersion` varchar(50) NULL,
    `fwVersion` varchar(50) NULL,
    `hwVersion` varchar(50) NULL,
    `imsi` varchar(50) NULL,
    `protocolType` varchar(50) NULL,
    `radiusIp` varchar(50) NULL,
    `bridgeId` varchar(50) NULL,
    `sigVersion` varchar(50) NULL,
    `serialNumber` varchar(50) NULL,
    `lnglat` varchar(255) NULL,
    `height` varchar(255) NULL,
    `reportData` longtext NULL,
    `systemType` varchar(50) NULL,
    `systemTypeName` varchar(50) NULL,
    `unitName` varchar(50) NULL,
    `buildName` varchar(50) NULL,
    `areaName` varchar(50) NULL,
    `deviceTypeId` varchar(50) NULL,
    `deviceTypeName` varchar(50) NULL,
    PRIMARY KEY (`deviceId`)
);

CREATE TABLE `iot_deviceservice` (
    `serviceId` varchar(50) NOT NULL,
    `deviceId` varchar(50) NOT NULL,
    `ycYxSetNo` int(11) NULL,
    `serviceType` varchar(50) NULL,
    `serviceModel` varchar(50) NULL,
    `serviceOption` varchar(50) NULL,
    `description` longtext NULL,
    `currentDate` varchar(50) NULL,
    `serviceModelId` varchar(50) NULL,
    `serviceModelName` varchar(50) NULL,
    `reportMode` varchar(50) NULL,
    `reportTimespan` int(11) NOT NULL,
    `reportLimit` float NOT NULL,
    PRIMARY KEY (`serviceId`, `deviceId`)
);

CREATE TABLE `iot_deviceservicemodel` (
    `serviceModelId` varchar(50) NOT NULL,
    `serviceModelName` varchar(50) NULL,
    PRIMARY KEY (`serviceModelId`)
);

CREATE TABLE `iot_devicetype` (
    `deviceTypeId` varchar(50) NOT NULL,
    `devuceTypeName` varchar(255) NULL,
    PRIMARY KEY (`deviceTypeId`)
);

CREATE TABLE `kingkang_cardatdoor` (
    `card_id` int(11) NULL DEFAULT '0',
    `equip_no` int(11) NULL DEFAULT '0',
    `group_id` int(11) NULL DEFAULT '0'
);

CREATE TABLE `kingkang_dept` (
    `dept_id` int(11) NULL,
    `dept_nm` varchar(24) NOT NULL
);

CREATE TABLE `kingkang_member` (
    `card_id` int(11) NOT NULL AUTO_INCREMENT,
    `dept_id` int(11) NULL,
    `name` varchar(8) NULL,
    `card_section` int(11) NULL DEFAULT '0',
    `card_code` int(11) NULL DEFAULT '0',
    `pwd` int(11) NULL DEFAULT '0',
    `tel` varchar(16) NULL,
    `addr` varchar(32) NULL,
    PRIMARY KEY (`card_id`)
);

CREATE TABLE `kingkang_tmg` (
    `equip_no` int(11) NULL DEFAULT '0',
    `group_id` int(11) NULL DEFAULT '0',
    `group_nm` varchar(32) NOT NULL
);

CREATE TABLE `matafun` (
    `matatype` varchar(5) NULL,
    `mainfunid` varchar(2) NULL,
    `mainfunnm` varchar(10) NULL,
    `minfunid` varchar(2) NULL,
    `minfunnm` varchar(10) NULL
);

CREATE TABLE `mataobj` (
    `matatype` varchar(5) NULL,
    `equiptype` varchar(20) NULL
);

CREATE TABLE `matasubtype` (
    `equiptype` varchar(20) NULL,
    `equipsubtype` varchar(32) NULL
);

CREATE TABLE `matasymb` (
    `MATATYPE` varchar(5) NULL,
    `MATANAME` varchar(20) NULL,
    `MATAARRAY` varchar(4) NULL,
    `MATAPIC` varchar(12) NULL
);

CREATE TABLE `nsladmission` (
    `sta_n` int(11) NOT NULL,
    `equip_no` int(11) NOT NULL,
    `Card_No` varchar(4) NOT NULL,
    `Reader` int(11) NULL DEFAULT '1',
    `Permission` bit(1) NOT NULL DEFAULT b'0'
);

CREATE TABLE `nslcardno` (
    `sta_n` int(11) NOT NULL,
    `equip_no` int(11) NOT NULL,
    `Card_No` varchar(4) NOT NULL,
    `Card_Code` varchar(8) NOT NULL,
    `Pin_code` varchar(4) NULL,
    `Name` varchar(32) NULL,
    `WeekGroup` varchar(1) NOT NULL DEFAULT '1'
);

CREATE TABLE `nsldateg` (
    `TimeGroup` int(11) NOT NULL DEFAULT '1',
    `Admit_Bgn1` varchar(4) NOT NULL,
    `Admit_End1` varchar(4) NULL,
    `Admit_Bgn2` varchar(4) NULL,
    `Admit_End2` varchar(4) NULL
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
    `sta_nm` varchar(10) NOT NULL,
    `equip_id` varchar(16) NOT NULL,
    `equip_nm` varchar(64) NULL,
    `equiptype` varchar(20) NOT NULL,
    PRIMARY KEY (`sta_nm`, `equip_id`)
);

CREATE TABLE `operationlog` (
    `OPERATION_ID` int(11) NOT NULL AUTO_INCREMENT,
    `sta_nm` varchar(10) NOT NULL,
    `OPERATION_TITLE` varchar(255) NULL,
    `OPERATION_PERSION` varchar(16) NULL,
    PRIMARY KEY (`OPERATION_ID`)
);

CREATE TABLE `operationrec` (
    `OPERATION_ID` int(11) NOT NULL AUTO_INCREMENT,
    `OPERATION_TITLE` varchar(255) NOT NULL,
    `OPERATION_PERSION` varchar(16) NULL,
    `OPERATION_COMMENT` varchar(255) NULL,
    `OPERATION_PROCEDURE` longblob NULL,
    PRIMARY KEY (`OPERATION_ID`)
);

CREATE TABLE `personnel.faceimage` (
    `PkId` int(11) NOT NULL AUTO_INCREMENT,
    `id` varchar(100) NOT NULL,
    `sourceId` varchar(100) NULL,
    `race` varchar(100) NULL,
    `sourceType` varchar(100) NULL,
    `imageUri` varchar(200) NULL,
    `type` varchar(100) NULL,
    `alarmId` varchar(100) NULL,
    `flagId` int(11) NULL,
    `HashId` bigint(20) NULL,
    PRIMARY KEY (`PkId`)
);

CREATE TABLE `rawequip` (
    `raw_equip_no` int(11) NULL DEFAULT '0',
    `raw_equip_nm` varchar(64) NULL,
    `equip_detail` varchar(255) NULL,
    `acc_cyc` int(11) NULL DEFAULT '1',
    `related_pic` varchar(16) NULL,
    `proc_advice` varchar(254) NULL,
    `out_of_contact` varchar(64) NOT NULL,
    `contacted` varchar(64) NULL,
    `event_wav` varchar(15) NULL,
    `communicaton_type` int(11) NULL DEFAULT '0',
    `communication_drv` varchar(16) NULL,
    `local_addr` varchar(64) NULL,
    `equip_addr` varchar(128) NULL,
    `communication_param` varchar(64) NULL,
    `communication_time_param` varchar(32) NULL,
    `tabname` varchar(15) NULL,
    `alarm_scheme` int(11) NULL DEFAULT '0',
    `attrib` int(11) NULL DEFAULT '0'
);

CREATE TABLE `rawycp` (
    `raw_equip_no` int(11) NULL DEFAULT '0',
    `raw_yc_no` int(11) NULL DEFAULT '0',
    `raw_yc_nm` varchar(64) NULL,
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
    `main_instruction` varchar(128) NULL,
    `minor_instruction` varchar(128) NULL,
    `alarm_acceptable_time` int(11) NULL DEFAULT '0',
    `restore_acceptable_time` int(11) NULL DEFAULT '0',
    `alarm_repeat_time` int(11) NULL DEFAULT '0',
    `proc_advice` varchar(254) NULL,
    `lvl_level` int(11) NULL,
    `outmin_evt` varchar(64) NULL,
    `outmax_evt` varchar(64) NULL,
    `wave_file` varchar(24) NULL,
    `related_pic` int(11) NULL DEFAULT '-1',
    `alarm_scheme` int(11) NULL DEFAULT '1',
    `curve_rcd` bit(1) NOT NULL DEFAULT b'0'
);

CREATE TABLE `rawyxp` (
    `raw_equip_no` int(11) NULL DEFAULT '0',
    `raw_yx_no` int(11) NULL DEFAULT '0',
    `raw_yx_nm` varchar(64) NULL,
    `proc_advice_r` varchar(254) NULL,
    `proc_advice_d` varchar(254) NULL,
    `level_r` int(11) NULL,
    `level_d` int(11) NULL,
    `evt_01` varchar(64) NULL,
    `evt_10` varchar(64) NULL,
    `alarm_acceptable_time` int(11) NULL DEFAULT '0',
    `restore_acceptable_time` int(11) NULL DEFAULT '0',
    `alarm_repeat_time` int(11) NULL DEFAULT '0',
    `main_instruction` varchar(128) NULL,
    `minor_instruction` varchar(128) NULL,
    `wave_file` varchar(24) NULL,
    `related_pic` int(11) NULL DEFAULT '-1',
    `inversion` bit(1) NOT NULL DEFAULT b'0',
    `alarm_scheme` int(11) NULL DEFAULT '0',
    `initval` int(11) NULL DEFAULT '0',
    `val_trait` int(11) NULL DEFAULT '0'
);

CREATE TABLE `resdscp` (
    `ResIdenti` varchar(240) NULL,
    `ResName` varchar(48) NULL,
    `ResType` int(11) NULL DEFAULT '1'
);

CREATE TABLE `rtuyxtab` (
    `sta_n` varchar(2) NULL,
    `equip_no` varchar(3) NULL,
    `yx_no` varchar(3) NULL,
    `flag` bit(1) NOT NULL DEFAULT b'0'
);

CREATE TABLE `sc302encode` (
    `sta_n` varchar(2) NOT NULL DEFAULT '01',
    `equip_no` varchar(2) NOT NULL,
    `CardNo` varchar(8) NOT NULL,
    `Pin` varchar(8) NULL,
    `Name` varchar(32) NULL,
    `TimeGroup` varchar(1) NOT NULL DEFAULT '1',
    `Door` varchar(1) NOT NULL DEFAULT '1'
);

CREATE TABLE `sc302timeg` (
    `sta_n` varchar(2) NOT NULL,
    `equip_no` varchar(2) NOT NULL,
    `TimeGroup` varchar(1) NOT NULL,
    `Mon` varchar(8) NULL,
    `Tue` varchar(8) NULL,
    `Wed` varchar(8) NULL,
    `Thu` varchar(8) NULL,
    `Fri` varchar(8) NULL,
    `Sat` varchar(8) NULL,
    `Sun` varchar(8) NULL
);

CREATE TABLE `setevt` (
    `sta_n` int(11) NULL DEFAULT '0',
    `equip_no` int(11) NOT NULL,
    `event` varchar(128) NOT NULL,
    `operator` longtext NOT NULL,
    `gwsource` longtext NULL
);

CREATE TABLE `setparm` (
    `equip_no` int(11) NOT NULL,
    `set_no` int(11) NOT NULL,
    `sta_n` int(11) NULL DEFAULT '0',
    `set_nm` longtext NULL,
    `set_type` varchar(1) NULL,
    `main_instruction` varchar(64) NULL,
    `minor_instruction` longtext NULL,
    `record` bit(1) NOT NULL DEFAULT b'1',
    `action` varchar(16) NULL DEFAULT '设置',
    `value` longtext NULL,
    `canexecution` bit(1) NOT NULL DEFAULT b'1',
    `VoiceKeys` longtext NULL,
    `EnableVoice` bit(1) NOT NULL DEFAULT b'0',
    `Reserve1` longtext NULL,
    `Reserve2` longtext NULL,
    `Reserve3` longtext NULL,
    `qr_equip_no` int(11) NULL DEFAULT '0',
    PRIMARY KEY (`equip_no`, `set_no`)
);

CREATE TABLE `smsreqcont` (
    `ReqID` int(11) NULL DEFAULT '0',
    `Task` varchar(128) NULL,
    `Type` varchar(2) NULL,
    `EquipNo` int(11) NULL,
    `YcYxNo` int(11) NULL,
    `main_instruction` varchar(64) NULL,
    `minor_instruction` varchar(64) NULL,
    `value` varchar(32) NULL,
    `Remark` varchar(255) NULL
);

CREATE TABLE `smsreqlist` (
    `ReqID` int(11) NULL DEFAULT '0',
    `ReqName` varchar(64) NULL,
    `Comment` varchar(128) NULL
);

CREATE TABLE `spealmreport` (
    `id` int(11) NOT NULL,
    `sta_n` int(11) NULL DEFAULT '0',
    `group_no` int(11) NULL DEFAULT '0',
    `Administrator` varchar(32) NULL,
    `remark` longtext NULL
);

CREATE TABLE `station` (
    `sta_n` int(11) NULL DEFAULT '0',
    `sta_nm` varchar(64) NOT NULL,
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
    `name` varchar(8) NULL,
    `card_no` varchar(50) NULL,
    `cardid` varchar(50) NULL,
    `app` varchar(2) NULL,
    `cardtype` varchar(2) NULL,
    `pin` varchar(50) NULL
);

CREATE TABLE `sydatag` (
    `DataGroup` int(11) NULL DEFAULT '0',
    `TimeG1` int(11) NULL DEFAULT '0',
    `TimeG2` int(11) NULL DEFAULT '0',
    `TimeG3` int(11) NULL DEFAULT '0'
);

CREATE TABLE `sysevt` (
    `sta_n` int(11) NULL DEFAULT '0',
    `event` longtext NULL,
    `confirmname` varchar(128) NULL,
    `confirmremark` varchar(255) NULL,
    `GUID` varchar(255) NULL
);

CREATE TABLE `sytimeg` (
    `TimeGroup` int(11) NULL DEFAULT '0',
    `Admit_Bgn` varchar(4) NULL,
    `Admit_End` varchar(4) NULL
);

CREATE TABLE `tc_inoutls` (
    `ID` int(11) NOT NULL AUTO_INCREMENT,
    `Car_No` varchar(255) NULL,
    `Card_no` varchar(255) NULL,
    `Ctrl_No_i` varchar(255) NULL,
    `Ctrl_No_InVideo` varchar(255) NULL,
    `Ctrl_No_o` varchar(255) NULL,
    `Ctrl_No_OutVideo` varchar(255) NULL,
    `CardType` varchar(255) NULL,
    `Car_Type` varchar(255) NULL,
    PRIMARY KEY (`ID`)
);

CREATE TABLE `telphone` (
    `sta_n` varchar(2) NOT NULL,
    `equip_no` varchar(2) NOT NULL,
    `phone_num` varchar(30) NOT NULL,
    `name` varchar(30) NULL,
    `permit` bit(1) NOT NULL DEFAULT b'0',
    `if_call_machine` bit(1) NOT NULL DEFAULT b'0',
    `wait_before_speak` int(11) NULL DEFAULT '0',
    `call_machine_funct_key` varchar(15) NULL,
    `call_machine_final_key` varchar(50) NULL,
    `dial_interval` int(11) NULL DEFAULT '0',
    `dial_repeat` int(11) NULL DEFAULT '0',
    PRIMARY KEY (`sta_n`, `equip_no`, `phone_num`)
);

CREATE TABLE `visitorrecord` (
    `ID` double NOT NULL,
    `sex` varchar(255) NULL,
    `Visitor` varchar(255) NULL,
    `LicenseCode` varchar(255) NULL,
    `LicenseType` varchar(255) NULL,
    `Address` longtext NULL,
    `Nation` varchar(255) NULL,
    `IssuingAgency` longtext NULL,
    `Phone` double NULL,
    `Remark` longtext NULL,
    `Company` longtext NULL,
    `PeerNum` double NULL,
    `Event` varchar(255) NULL,
    `Photo` longtext NULL,
    `QRCode` longtext NULL,
    PRIMARY KEY (`ID`)
);

CREATE TABLE `weekalmreport` (
    `id` int(11) NOT NULL,
    `sta_n` int(11) NULL DEFAULT '0',
    `group_no` int(11) NULL DEFAULT '0',
    `Administrator` varchar(32) NULL,
    `week_day` int(11) NULL DEFAULT '0',
    `remark` longtext NULL
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
    `JSONContent` text NULL,
    `BgImage` text NULL,
    `Type` int(11) NULL,
    `siginalVal` text NULL,
    `ID` int(11) NOT NULL
);

CREATE TABLE `woacceptorder` (
    `id` int(11) NOT NULL AUTO_INCREMENT,
    `work_order_id` varchar(32) NOT NULL,
    `current_processor` int(11) NOT NULL,
    `personnel` varchar(30) NOT NULL,
    `claim` int(11) NOT NULL,
    `transfer_personnel` varchar(30) NOT NULL,
    `created_time` varchar(30) NOT NULL,
    PRIMARY KEY (`id`)
);

CREATE TABLE `woattachment` (
    `id` varchar(32) NOT NULL,
    `work_order_id` varchar(32) NOT NULL,
    `save_date` varchar(20) NOT NULL,
    `name` varchar(30) NOT NULL,
    `extension` varchar(10) NOT NULL,
    `created_time` varchar(30) NOT NULL,
    PRIMARY KEY (`id`)
);

CREATE TABLE `womainfeedbackattachment` (
    `id` varchar(32) NOT NULL,
    `feedback_id` varchar(32) NOT NULL,
    `save_date` varchar(20) NOT NULL,
    `name` varchar(30) NOT NULL,
    `extension` varchar(10) NOT NULL,
    PRIMARY KEY (`id`)
);

CREATE TABLE `womainfeedbackconfirm` (
    `id` int(11) NOT NULL AUTO_INCREMENT,
    `work_order_id` varchar(32) NOT NULL,
    `feedback_id` varchar(32) NOT NULL,
    `status` int(11) NOT NULL,
    `remark` longtext NULL,
    `creator` varchar(30) NOT NULL,
    PRIMARY KEY (`id`)
);

CREATE TABLE `womaintenancefeedback` (
    `id` varchar(32) NOT NULL,
    `accept_order_id` int(11) NOT NULL,
    `level` int(11) NOT NULL,
    `maintenance_time` varchar(30) NOT NULL,
    `status` int(11) NOT NULL,
    `cause_issue` longtext NULL,
    `process_content` longtext NULL,
    `created_time` varchar(30) NOT NULL,
    PRIMARY KEY (`id`)
);

CREATE TABLE `worecord` (
    `id` int(11) NOT NULL AUTO_INCREMENT,
    `work_order_id` varchar(32) NOT NULL,
    `description` longtext NOT NULL,
    `creator` varchar(30) NOT NULL,
    `created_time` varchar(30) NOT NULL,
    PRIMARY KEY (`id`)
);

CREATE TABLE `workorder` (
    `id` varchar(32) NOT NULL,
    `equip_type` varchar(50) NOT NULL,
    `topic` varchar(50) NOT NULL,
    `level` int(11) NOT NULL,
    `maintenance_site` varchar(100) NOT NULL,
    `maintenance_time` varchar(30) NOT NULL,
    `content` longtext NOT NULL,
    `status` int(11) NOT NULL,
    `creator` varchar(30) NOT NULL,
    `reason` longtext NULL,
    `created_time` varchar(30) NOT NULL,
    `modified_time` varchar(30) NOT NULL,
    `completed_time` varchar(30) NULL,
    PRIMARY KEY (`id`)
);

CREATE TABLE `workstation` (
    `sta_n` int(11) NULL DEFAULT '0',
    `sta_nm` varchar(64) NULL,
    `sta_type` varchar(2) NULL,
    `net_addr` varchar(32) NULL,
    `sub_path` varchar(64) NULL
);

CREATE TABLE `ycp` (
    `equip_no` int(11) NOT NULL,
    `yc_no` int(11) NOT NULL,
    `sta_n` int(11) NULL DEFAULT '0',
    `yc_nm` varchar(80) NULL,
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
    `main_instruction` varchar(254) NULL,
    `minor_instruction` varchar(254) NULL,
    `alarm_acceptable_time` int(11) NULL DEFAULT '0',
    `restore_acceptable_time` int(11) NULL DEFAULT '0',
    `alarm_repeat_time` int(11) NULL DEFAULT '0',
    `proc_advice` varchar(254) NULL,
    `lvl_level` int(11) NOT NULL,
    `outmin_evt` varchar(64) NULL,
    `outmax_evt` varchar(64) NULL,
    `wave_file` varchar(64) NULL,
    `related_pic` varchar(255) NULL,
    `alarm_scheme` int(11) NULL DEFAULT '0',
    `curve_rcd` bit(1) NOT NULL DEFAULT b'0',
    `curve_limit` double NULL DEFAULT '0',
    `alarm_shield` longtext NULL,
    `unit` varchar(50) NULL,
    `AlarmRiseCycle` int(11) NULL DEFAULT '0',
    `Reserve1` longtext NULL,
    `Reserve2` longtext NULL,
    `Reserve3` longtext NULL,
    `related_video` varchar(255) NULL,
    `ZiChanID` varchar(255) NULL,
    `PlanNo` varchar(255) NULL,
    `SafeTime` longtext NULL,
    PRIMARY KEY (`equip_no`, `yc_no`)
);

CREATE TABLE `ycyxevt` (
    `sta_n` int(11) NULL DEFAULT '0',
    `equip_no` int(11) NOT NULL,
    `ycyx_no` int(11) NOT NULL,
    `ycyx_type` varchar(1) NOT NULL,
    `event` varchar(255) NOT NULL,
    `proc_rec` varchar(255) NULL,
    `confirmname` varchar(128) NULL,
    `confirmremark` varchar(255) NULL,
    `WuBao` varchar(10) NOT NULL DEFAULT '0',
    `alarmlevel` int(11) NULL,
    `AlarmState` int(11) NOT NULL,
    `GUID` varchar(255) NULL
);

CREATE TABLE `ycyxevtreport` (
    `name` varchar(64) NULL,
    `sta_n` int(11) NULL,
    `equip_no` int(11) NOT NULL,
    `ycyx_no` int(11) NOT NULL,
    `ycyx_type` varchar(1) NOT NULL,
    `index_num` int(11) NULL DEFAULT '0'
);

CREATE TABLE `yxp` (
    `equip_no` int(11) NOT NULL,
    `yx_no` int(11) NOT NULL,
    `sta_n` int(11) NULL DEFAULT '0',
    `yx_nm` varchar(80) NULL,
    `proc_advice_r` varchar(254) NULL,
    `proc_advice_d` varchar(254) NULL,
    `level_r` int(11) NOT NULL,
    `level_d` int(11) NOT NULL,
    `evt_01` varchar(64) NULL,
    `evt_10` varchar(64) NULL,
    `main_instruction` varchar(254) NULL,
    `minor_instruction` varchar(254) NULL,
    `alarm_acceptable_time` int(11) NULL DEFAULT '0',
    `restore_acceptable_time` int(11) NULL DEFAULT '0',
    `alarm_repeat_time` int(11) NULL DEFAULT '0',
    `wave_file` varchar(64) NULL,
    `related_pic` varchar(255) NULL,
    `alarm_scheme` int(11) NULL DEFAULT '0',
    `inversion` bit(1) NOT NULL DEFAULT b'0',
    `initval` int(11) NULL DEFAULT '0',
    `val_trait` int(11) NULL DEFAULT '0',
    `alarm_shield` longtext NULL,
    `AlarmRiseCycle` int(11) NULL DEFAULT '0',
    `curve_rcd` bit(1) NOT NULL DEFAULT b'0',
    `Reserve1` longtext NULL,
    `Reserve2` longtext NULL,
    `Reserve3` longtext NULL,
    `related_video` varchar(255) NULL,
    `ZiChanID` varchar(255) NULL,
    `PlanNo` varchar(255) NULL,
    `SafeTime` longtext NULL,
    PRIMARY KEY (`equip_no`, `yx_no`)
);

CREATE INDEX `IDXKingKang_TmG_group_id` ON `kingkang_tmg` (`group_id`);

CREATE INDEX `IDXVisitorRecord_ID` ON `visitorrecord` (`ID`);

CREATE INDEX `IDXVisitorRecord_LicenseCode` ON `visitorrecord` (`LicenseCode`);

CREATE INDEX `IDXVisitorRecord_PeerNum` ON `visitorrecord` (`PeerNum`);

