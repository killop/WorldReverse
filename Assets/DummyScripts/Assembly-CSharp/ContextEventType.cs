﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public enum ContextEventType // TypeDefIndex: 19101
{
	Invalid = 0,
	ContextEnd = 1,
	FrameEnd = 2,
	CloseEvent = 3,
	BackEvent = 4,
	ConfirmEvent = 5,
	ConfirmingEvent = 6,
	ConfirmingCancelEvent = 7,
	ToPrevPrimaryTabEvent = 8,
	ToNextPrimaryTabEvent = 9,
	ToPrevSecondaryTabEvent = 10,
	ToNextSecondaryTabEvent = 11,
	MenuNavigationUp = 12,
	MenuNavigationDown = 13,
	MenuNavigationLeft = 14,
	MenuNavigationRight = 15,
	IncreaseCountEvent = 16,
	DecreaseCountEvent = 17,
	TriggerInputEvent = 18,
	LogoutConfirmingEvent = 19,
	LogoutConfirmEndEvent = 20,
	BackingEvent = 21,
	BackingCancelEvent = 22,
	OpenSortingDropdownEvent = 23,
	OpenScreenDropdownEvent = 24,
	RevertSortingOrderEvent = 25,
	OpenDropdownEvent = 26,
	ToNextDropdownOptionEvent = 27,
	ToPrevDropdownOptionEvent = 28,
	ConfirmDropdownSelectEvent = 29,
	CancelDropdownSelectEvent = 30,
	ScrollPrimaryScrollerEvent = 31,
	ReturnToQuestEvent = 32,
	ToAvatar1Event = 33,
	ToAvatar2Event = 34,
	ToAvatar3Event = 35,
	ToAvatar4Event = 36,
	OpenChatEvent = 37,
	ToAvatar5Event = 38,
	ActionNorthEvent = 39,
	ActionEastEvent = 40,
	ActionSouthEvent = 41,
	ActionWestEvent = 42,
	ShowItemDetailEvent = 43,
	ShowPlayerLevelRewardEvent = 44,
	ChangeTeamEvent = 45,
	ChangeTeamNameEvent = 46,
	FastTeamSelectEvent = 47,
	SubmitFastTeamSelect = 48,
	ShowHelpTips = 49,
	BuyResin = 51,
	ChangeFocusZone = 52,
	ShowCycleDungeonOnly = 53,
	ChangeCustomMarkName = 54,
	RemoveCustomMark = 55,
	OpenChatCancelEvent = 56,
	IncreaseCountReleaseEvent = 57,
	DecreaseCountReleaseEvent = 58,
	ItemSourceSelectEvent = 59,
	ChallengeInterruptEvent = 60,
	ToNextScrollerOptionEvent = 61,
	ToPrevScrollerOptionEvent = 62,
	ConfirmScrollerSelectEvent = 63,
	CancelScrollerSelectEvent = 64,
	ToRewardDetailEvent = 100,
	ToPrevRewardEvent = 101,
	ToNextRewardEvent = 102,
	ToPrevMainQuestEvent = 103,
	ToNextMainQuestEvent = 104,
	ToggleChapterFold = 105,
	NavigateToQuestEvent = 106,
	ScrollSubQuestEvent = 107,
	ChapterSelectEvent = 108,
	ChoosePrevChapterEvent = 109,
	ChooseNextChapterEvent = 110,
	ShowSubQuestDetailEvent = 111,
	ToRewardPageEvent = 112,
	ToggleQuestTrackingEvent = 113,
	ToPrevTabEvent = 200,
	ToNextTabEvent = 201,
	UseEvent = 202,
	DropEvent = 203,
	ToPrevRowEvent = 204,
	ToNextRowEvent = 205,
	ToPrevSlotEvent = 206,
	ToNextSlotEvent = 207,
	ReNameEvent = 300,
	UIZoomCameraEvent = 400,
	UIDetails = 401,
	MoveCursorEvent = 500,
	ZoomInMapEvent = 501,
	ZoomOutMapEvent = 502,
	CommonLeftStickUpEvent = 600,
	CommonLeftStickDownEvent = 601,
	CommonLeftStickLeftEvent = 602,
	CommonLeftStickRightEvent = 603,
	CommonChangeViewEvent = 604,
	CommonMenuUpEvent = 605,
	CommonMenuLeftEvent = 606,
	CommonRightStickLeftEvent = 607,
	CommonRightStickRightEvent = 608,
	CommonLeftStickButtonEvent = 610,
	CommonRightStickButtonEvent = 611,
	CommonRightTriggerEvent = 612,
	CommonLeftTriggerEvent = 613,
	CommonRightShoulderEvent = 614,
	CommonLeftShoulderEvent = 615,
	CommonLeftShoulderReleaseEvent = 616,
	CommonRightShoulderReleaseEvent = 617,
	CommonLeftStickVerticalEvent = 620,
	CommonRightStickVerticalEvent = 621,
	CommonLeftStickHorizontalEvent = 622,
	CommonRightStickUpEvent = 630,
	CommonRightStickDownEvent = 631,
	Revive = 700,
	Goddess_ContributeSome = 800,
	Goddess_ContributeAll = 801,
	Goddess_ScrollUpgradeReward = 802,
	ToggleSpringAutoUseEvent = 803,
	DialogSelectEvent = 900,
	ToNextDialogEvent = 901,
	VisitorLoginEvent = 1000,
	SwitchServerLoginEvent = 1001,
	GachaNoticeEvent = 1020,
	GachaHistoryEvent = 1021,
	GachaOnceEvent = 1022,
	GachaTenTimesEvent = 1023,
	GachaNextEvent = 1024,
	BuyEvent = 1101,
	TipsEvent = 1102,
	BuyInfoEvent = 1103,
	MallHelpEvent = 1104,
	MaterialAddEvent = 1201,
	McoinAddEvent = 1202,
	HideEvent = 1301,
	PhotographOpenEmotion = 1302,
	QuickUseEvent = 1401,
	ActivitySkillEvent = 1402,
	ExteraSelectUpEvent = 1403,
	ExteraSelectDownEvent = 1404,
	ExteraSelectLeftEvent = 1405,
	ExteraSelectRightEvent = 1406,
	MusicGameLeftUpEvent = 1407,
	MusicGameLeftRightEvent = 1408,
	MusicGameLeftDownEvent = 1409,
	MusicGameLeftLeftEvent = 1410,
	MusicGameRightUpEvent = 1411,
	MusicGameRightRightEvent = 1412,
	MusicGameRightDownEvent = 1413,
	MusicGameRightLeftEvent = 1414,
	MusicGameFree1Event = 1415,
	MusicGameFree2Event = 1416,
	MusicGameFree3Event = 1417,
	MusicGameFree4Event = 1418,
	MusicGameFree5Event = 1419,
	MusicGameFree6Event = 1420,
	MusicGameFree7Event = 1421,
	MusicGameFree8Event = 1422,
	MusicGameFree9Event = 1423,
	MusicGameFree10Event = 1424,
	MusicGameFree11Event = 1425,
	MusicGameFree12Event = 1426,
	MusicGameFree13Event = 1427,
	MusicGameFree14Event = 1428,
	MusicGameFree15Event = 1429,
	MusicGameFree16Event = 1430,
	MusicGameFree17Event = 1431,
	MusicGameFree18Event = 1432,
	MusicGameFree19Event = 1433,
	MusicGameFree20Event = 1434,
	MusicGameFree21Event = 1435,
	MusicGamePauseEvent = 1436
}

