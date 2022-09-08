﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public enum ActionReasonType // TypeDefIndex: 25906
{
	ActionReasonNone = 0,
	ActionReasonQuestItem = 1,
	ActionReasonQuestReward = 2,
	ActionReasonTrifle = 3,
	ActionReasonShop = 4,
	ActionReasonPlayerUpgradeReward = 5,
	ActionReasonAddAvatar = 6,
	ActionReasonGadgetEnvAnimal = 7,
	ActionReasonMonsterEnvAnimal = 8,
	ActionReasonCompound = 9,
	ActionReasonCook = 10,
	ActionReasonGather = 11,
	ActionReasonMailAttachment = 12,
	ActionReasonCityLevelupReturn = 15,
	ActionReasonCityLevelupReward = 17,
	ActionReasonAreaExploreReward = 18,
	ActionReasonUnlockPointReward = 19,
	ActionReasonDungeonFirstPass = 20,
	ActionReasonDungeonPass = 21,
	ActionReasonChangeElemType = 23,
	ActionReasonFetterOpen = 25,
	ActionReasonDailyTaskScore = 26,
	ActionReasonDailyTaskHost = 27,
	ActionReasonRandTaskHost = 28,
	ActionReasonExpedition = 29,
	ActionReasonGacha = 30,
	ActionReasonCombine = 31,
	ActionReasonRandTaskGuest = 32,
	ActionReasonDailyTaskGuest = 33,
	ActionReasonForgeOutput = 34,
	ActionReasonForgeReturn = 35,
	ActionReasonInitAvatar = 36,
	ActionReasonMonsterDie = 37,
	ActionReasonGm = 38,
	ActionReasonOpenChest = 39,
	ActionReasonGadgetDie = 40,
	ActionReasonMonsterChangeHp = 41,
	ActionReasonSubfieldDrop = 42,
	ActionReasonPushTipsReward = 43,
	ActionReasonActivityMonsterDrop = 44,
	ActionReasonActivityGather = 45,
	ActionReasonActivitySubfieldDrop = 46,
	ActionReasonTowerScheduleReward = 47,
	ActionReasonTowerFloorStarReward = 48,
	ActionReasonTowerFirstPassReward = 49,
	ActionReasonTowerDailyReward = 50,
	ActionReasonHitClientTrivialEntity = 51,
	ActionReasonOpenWorldBossChest = 52,
	ActionReasonMaterialDeleteReturn = 53,
	ActionReasonSignInReward = 54,
	ActionReasonOpenBlossomChest = 55,
	ActionReasonRecharge = 56,
	ActionReasonBonusActivityReward = 57,
	ActionReasonTowerCommemorativeReward = 58,
	ActionReasonTowerSkipFloorReward = 59,
	ActionReasonRechargeBonus = 60,
	ActionReasonRechargeCard = 61,
	ActionReasonRechargeCardDaily = 62,
	ActionReasonRechargeCardReplace = 63,
	ActionReasonRechargeCardReplaceFree = 64,
	ActionReasonRechargePlayReplace = 65,
	ActionReasonMpPlayTakeReward = 66,
	ActionReasonActivityWatcher = 67,
	ActionReasonSalesmanDeliverItem = 68,
	ActionReasonSalesmanReward = 69,
	ActionReasonRebate = 70,
	ActionReasonMcoinExchangeHcoin = 71,
	ActionReasonDailyTaskExchangeLegendaryKey = 72,
	ActionReasonUnlockPersonLine = 73,
	ActionReasonFetterLevelReward = 74,
	ActionReasonBuyResin = 75,
	ActionReasonRechargePackage = 76,
	ActionReasonDeliveryDailyReward = 77,
	ActionReasonCityReputationLevel = 78,
	ActionReasonCityReputationQuest = 79,
	ActionReasonCityReputationRequest = 80,
	ActionReasonCityReputationExplore = 81,
	ActionReasonOffergingLevel = 82,
	ActionReasonRoutineHost = 83,
	ActionReasonRoutineGuest = 84,
	ActionReasonTreasureMapSpotToken = 89,
	ActionReasonTreasureMapBonusLevelReward = 90,
	ActionReasonTreasureMapMpReward = 91,
	ActionReasonConvert = 92,
	ActionReasonOverflowTransform = 93,
	ActionReasonActivityAvatarSelectionReward = 96,
	ActionReasonActivityWatcherBatch = 97,
	ActionReasonHitTreeDrop = 98,
	ActionReasonGetHomeLevelupReward = 99,
	ActionReasonHomeDefaultFurniture = 100,
	ActionReasonActivityCond = 101,
	ActionReasonBattlePassNotify = 102,
	ActionReasonPlayerUseItem = 1001,
	ActionReasonDropItem = 1002,
	ActionReasonWeaponUpgrade = 1011,
	ActionReasonWeaponPromote = 1012,
	ActionReasonWeaponAwaken = 1013,
	ActionReasonRelicUpgrade = 1014,
	ActionReasonAbility = 1015,
	ActionReasonDungeonStatueDrop = 1016,
	ActionReasonOfflineMsg = 1017,
	ActionReasonAvatarUpgrade = 1018,
	ActionReasonAvatarPromote = 1019,
	ActionReasonQuestAction = 1021,
	ActionReasonCityLevelup = 1022,
	ActionReasonUpgradeSkill = 1024,
	ActionReasonUnlockTalent = 1025,
	ActionReasonUpgradeProudSkill = 1026,
	ActionReasonPlayerLevelLimitUp = 1027,
	ActionReasonDungeonDaily = 1028,
	ActionReasonItemGiving = 1030,
	ActionReasonForgeCost = 1031,
	ActionReasonInvestigationReward = 1032,
	ActionReasonInvestigationTargetReward = 1033,
	ActionReasonGadgetInteract = 1034,
	ActionReasonSeaLampCiMaterial = 1036,
	ActionReasonSeaLampContributionReward = 1037,
	ActionReasonSeaLampPhaseReward = 1038,
	ActionReasonSeaLampFlyLamp = 1039,
	ActionReasonAutoRecover = 1040,
	ActionReasonActivityExpireItem = 1041,
	ActionReasonSubCoinNegative = 1042,
	ActionReasonBargainDeduct = 1043,
	ActionReasonBattlePassPaidReward = 1044,
	ActionReasonBattlePassLevelReward = 1045,
	ActionReasonTrialAvatarActivityFirstPassReward = 1046,
	ActionReasonBuyBattlePassLevel = 1047,
	ActionReasonGrantBirthdayBenefit = 1048,
	ActionReasonAchievementReward = 1049,
	ActionReasonAchievementGoalReward = 1050,
	ActionReasonFirstShareToSocialNetwork = 1051,
	ActionReasonDestroyMaterial = 1052,
	ActionReasonCodexLevelupReward = 1053,
	ActionReasonHuntingOfferReward = 1054,
	ActionReasonUseWidgetAnchorPoint = 1055,
	ActionReasonUseWidgetBonfire = 1056,
	ActionReasonUngradeWeaponReturnMaterial = 1057,
	ActionReasonUseWidgetOneoffGatherPointDetector = 1058,
	ActionReasonUseWidgetClientCollector = 1059,
	ActionReasonUseWidgetClientDetector = 1060,
	ActionReasonTakeGeneralReward = 1061,
	ActionReasonAsterTakeSpecialReward = 1062,
	ActionReasonRemoveCodexBook = 1063,
	ActionReasonOfferingItem = 1064,
	ActionReasonUseWidgetGadgetBuilder = 1065,
	ActionReasonEffigyFirstPassReward = 1066,
	ActionReasonEffigyReward = 1067,
	ActionReasonReunionFirstGiftReward = 1068,
	ActionReasonReunionSignInReward = 1069,
	ActionReasonReunionWatcherReward = 1070,
	ActionReasonSalesmanMpReward = 1071,
	ActionReasionAvatarPromoteReward = 1072,
	ActionReasonBlessingRedeemReward = 1073,
	ActionMiracleRingReward = 1074,
	ActionReasonExpeditionReward = 1075,
	ActionReasonTreasureMapRemoveDetector = 1076,
	ActionReasonMechanicusDungeonTicket = 1077,
	ActionReasonMechanicusLevelupGear = 1078,
	ActionReasonMechanicusBattleSettle = 1079,
	ActionReasonRegionSearchReward = 1080,
	ActionReasonUnlockCoopChapter = 1081,
	ActionReasonTakeCoopReward = 1082,
	ActionReasonFleurFairDungeonReward = 1083,
	ActionReasonActivityScore = 1084,
	ActionReasonChannellerSlabOneoffDungeonReward = 1085,
	ActionReasonFurnitureMakeStart = 1086,
	ActionReasonFurnitureMakeTake = 1087,
	ActionReasonFurnitureMakeCancel = 1088,
	ActionReasonFurnitureMakeFastFinish = 1089,
	ActionReasonChannellerSlabLoopDungeonFirstPassReward = 1090,
	ActionReasonChannellerSlabLoopDungeonScoreReward = 1091,
	ActionReasonHomeLimitedShopBuy = 1092,
	ActionReasonHomeCoinCollect = 1093
}

